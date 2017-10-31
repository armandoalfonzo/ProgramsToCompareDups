using HtmlAgilityPack;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CompareDubs
{
    class CompareTwoNearDupes
    {
        #region Properties
        private SqlConnection m_db;

        public CompareTwoNearDupes()
        {
            // Initialize single db connection
            m_db = new SqlConnection(ConfigurationManager.ConnectionStrings["CaseLawContext"].ConnectionString);

            // Open the db connection
            m_db.Open();
        }
        #endregion

        #region Methods

        public void Process()
        {
            var source = ConfigurationManager.AppSettings.Get("RootImportDirectory")+ "NearDups.txt";
            // We read the csv which has the IDs
            var reader = new StreamReader(File.OpenRead(source));
            while (!reader.EndOfStream)
            {
                //We read the line
                var line = reader.ReadLine();
                //Split the columns to get the values
                var values = line.Split(',');

                Console.WriteLine("Processing document ids: " + values[0] + "|" + values[1]);
                GetNumericalDifference(int.Parse(values[0]), int.Parse(values[1]));
                ColumnCompare(values);


            } // End WHILE
        } //End Process


        /// <summary>
        /// receives two near dubs if the size difference is less than 30 saves the id in a text file
        /// </summary>
        /// <returns>numerical difference</returns>
        private void GetNumericalDifference(int DocumentIdA, int DocumentIdB)
        {
            int[] Ids = new int[2];
            int cont = 0;
            using (var cmd = m_db.CreateCommand())
            {
                cmd.CommandTimeout = 0;
                cmd.CommandText = @"select len(Text)CharLength
                                    from OpinionDocuments
                                    where SourceFile like '%Spider%' 
                                    and (OpinionDocumentId=@DocumentIdA
                                    or OpinionDocumentId=@DocumentIdB)";
                cmd.Parameters.Add("DocumentIdA", SqlDbType.Int).Value = DocumentIdA;
                cmd.Parameters.Add("DocumentIdB", SqlDbType.Int).Value = DocumentIdB;


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ids[cont] = Convert.ToInt32(reader["CharLength"]);
                        cont++;
                    }
                }
                if(Math.Abs((Ids[0]-Ids[1]))<=30)
                {
                    int difference = Math.Abs(Ids[0]-Ids[1]);
                   File.AppendAllText(ConfigurationManager.AppSettings.Get("RootImportDirectory") + "ExactNearDups.txt", DocumentIdA + " ExactNearDup: "+ DocumentIdB + " difference of " +difference + Environment.NewLine);
                }
            }
        }
        private void ColumnCompare(string[] ids)
        {
            //me falta poner el id en el documento y arreglar la clase party en el html agility pack 
            HtmlDocument CompleteHtml = new HtmlDocument();

            string[] htmls = new string[2];
            int cont = 0;
            using (var cmd = m_db.CreateCommand())
            {
                cmd.CommandTimeout = 0;
                cmd.CommandText = @"select Html
                                    from OpinionDocuments
                                    where SourceFile like '%Spider%'
                                     and (OpinionDocumentId=@DocumentIdA
                                    or OpinionDocumentId=@DocumentIdB)";
                cmd.Parameters.Add("DocumentIdA", SqlDbType.Int).Value = ids[0];
                cmd.Parameters.Add("DocumentIdB", SqlDbType.Int).Value = ids[1];


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        htmls[cont] = reader["Html"].ToString();
                        cont++;
                    }
                }
            }
            cont = 0;
            foreach (string html in htmls)
            {
                CompleteHtml.LoadHtml(html);
                if(string.IsNullOrEmpty(CompleteHtml.DocumentNode.SelectSingleNode("//div[@class='accordion']").ToString()))
                {
                    File.AppendAllText(ConfigurationManager.AppSettings.Get("RootImportDirectory") + "HtmlWithoutParyClass.txt", " this html has no class " +ids[cont]+ Environment.NewLine);
                }
                cont++;
            }
        }

        #endregion
    }
}
