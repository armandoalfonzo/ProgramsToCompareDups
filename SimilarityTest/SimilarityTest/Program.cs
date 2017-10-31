using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilarityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "";
            do
            {
                string number1 = "";
                string numero2 = "vjnhh";
                string numero3 = "        <h1 itemprop=\"headline\">         MIDWOOD ESTATES v. KALISH        </h1>                <div>         <div class=\"docket\">          Motion No. 2013-02157 KC.         </div>        </div>                <div class=\"tabs-list\">                 <ul>          <li class=\"decision-tab  active\"><a href=\"#\" class=\"decision-tab-link\" rel=\"decisions-container\">View Case</a></li>                             </ul>        </div>        <div itemprop=\"about\">         <div class=\"citation\">          <p id=\"ref_cite\">2015 NY Slip Op 75281(U)</p>                   </div>         <div class=\"party-name\">          <p>MIDWOOD ESTATES, Respondent, v. RAZI KALISH, Appellant.</p>         </div>         <div class=\"court-date\">          <p itemprop=\"publisher\" itemscope=\"\" itemtype=\"https://schema.org/Organization\">Supreme Court, Appellate Term, Second Department.</p>                    <p itemprop=\"datePublished\">Decided May 20, 2015.</p>                    <p itemprop=\"dateModified\" class=\"hide\">Decided May 20, 2015.</p>         </div>                 </div>       <div id=\"case_content\">   <p>Motion by appellant, returnable January 16, 2015, on an appeal from a final judgment of the Civil Court of the City of New York, Kings County, entered August 26, 2013, to continue a stay granted by decision and order on motion of this court dated December 3, 2013, and extended by decisions and orders on motions of this court dated April 9, 2014 and October 3, 2014. Separate motion by appellant, returnable March 3, 2015, for leave to withdraw the appeal and for an order directing the release of funds on deposit. Separate motion by appellant, returnable April 21, 2015, to withdraw the motion returnable March 3, 2015, \"to declare eviction null and void,\" and for an order directing the release of the funds on deposit to the Human Resources Administration.</p>  <h4>DECISION &amp; ORDER ON MOTION</h4>  <p>Upon the papers filed in support of the motions and the papers filed in opposition to the motion to continue the stay, it is</p>  <p>ORDERED, on the court's own motion, that appellant's motions are consolidated for purposes of disposition; and it is further,</p>  <p>ORDERED that appellant's motion to continue the stay is granted on condition that the appeal be perfected on or before July 10, 2015, and upon the further condition that within 10 days from the date of this decision and order on motion appellant pay respondent the sum of $1,528.44 and any and all arrears in rent and/or use and occupancy at the rate of $219.86 per month from February 1, 2015, and continue to pay use and occupancy to respondent at a like rate as it becomes due; and it is further,</p>  <p>ORDERED that in the event that any of the above conditions are not met, the court, on its own motion, may vacate the stay, or respondent may move to vacate the stay on three days' notice; and it is further,</p>  <p>ORDERED that the branch of appellant's motion returnable April 21, 2015 seeking to withdraw the motion returnable March 3, 2015 is granted and the motion returnable March 3, 2015 is marked withdrawn; and it is further,</p>  <p>ORDERED that appellant's motion returnable April 21, 2015 is otherwise denied.</p>   </div>                       ";
                string numero4 = "        <h1 itemprop=\"headline\">         MIDWOOD ESTATES v. KALISH        </h1>                <div>         <div class=\"docket\">          Motion No. 2013-02157 KC.         </div>        </div>                <div class=\"tabs-list\">                 <ul>          <li class=\"decision-tab  active\"><a href=\"#\" class=\"decision-tab-link\" rel=\"decisions-container\">View Case</a></li>                             </ul>        </div>        <div itemprop=\"about\">         <div class=\"citation\">          <p id=\"ref_cite\">2015 NY Slip Op 75281(U)</p>                   </div>         <div class=\"party-name\">          <p>MIDWOOD ESTATES, Respondent, v. RAZI KALISH, Appellant.</p>         </div>         <div class=\"court-date\">          <p itemprop=\"publisher\" itemscope=\"\" itemtype=\"https://schema.org/Organization\">Supreme Court, Appellate Term, Second Department.</p>                    <p itemprop=\"datePublished\">Decided May 20, 2015.</p>                    <p itemprop=\"dateModified\" class=\"hide\">Decided May 20, 2015.</p>         </div>                 </div>       <div id=\"case_content\">   <p>Motion by appellant, returnable January 16, 2015, on an appeal from a final judgment of the Civil Court of the City of New York, Kings County, entered August 26, 2013, to continue a stay granted by decision and order on motion of this court dated December 3, 2013, and extended by decisions and orders on motions of this court dated April 9, 2014 and October 3, 2014. Separate motion by appellant, returnable March 3, 2015, for leave to withdraw the appeal and for an order directing the release of funds on deposit. Separate motion by appellant, returnable April 21, 2015, to withdraw the motion returnable March 3, 2015, \"to declare eviction null and void,\" and for an order directing the release of the funds on deposit to the Human Resources Administration.</p>  <h4>DECISION &amp; ORDER ON MOTION</h4>  <p>Upon the papers filed in support of the motions and the papers filed in opposition to the motion to continue the stay, it is</p>  <p>ORDERED, on the court's own motion, that appellant's motions are consolidated for purposes of disposition; and it is further,</p>  <p>ORDERED that appellant's motion to continue the stay is granted on condition that the appeal be perfected on or before July 10, 2015, and upon the further condition that within 10 days from the date of this decision and order on motion appellant pay respondent the sum of $1,528.44 and any and all arrears in rent and/or use and occupancy at the rate of $219.86 per month from February 1, 2015, and continue to pay use and occupancy to respondent at a like rate as it becomes due; and it is further,</p>  <p>ORDERED that in the event that any of the above conditions are not met, the court, on its own motion, may vacate the stay, or respondent may move to vacate the stay on three days' notice; and it is further,</p>  <p>ORDERED that the branch of appellant's motion returnable April 21, 2015 seeking to withdraw the motion returnable March 3, 2015 is granted and the motion returnable March 3, 2015 is marked withdrawn; and it is further,</p>  <p>ORDERED that appellant's motion returnable April 21, 2015 is otherwise denied.</p>   </div>                       ";
                int percent = Compute(number1, numero2);
                Console.WriteLine(percent);
                Console.ReadKey();

                Console.WriteLine("para salir presione s");
                salir = Console.ReadLine();

            } while (salir != "s");
        }
        public static int Compute(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                if (string.IsNullOrEmpty(t))
                    return -1;
                return 100;
            }

            if (string.IsNullOrEmpty(t))
            {
                return 100;
            }

            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // initialize the top and right of the table to 0, 1, 2, ...
            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 1; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    int min1 = d[i - 1, j] + 1;
                    int min2 = d[i, j - 1] + 1;
                    int min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            if (s.Length > t.Length)
            {
                return ((int)(((double)d[n, m] / (double)s.Length) * (double)100));
            }
            return ((int)(((double)d[n, m] / (double)t.Length) * (double)100));

        }
    }
}
