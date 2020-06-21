using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentTesting
{
    //Make a public class to hold Team data
    public class Team
    {
        //Set the paths to find where the image resources are located; they need to use consistent naming
        private readonly string imgpathroot = "/Images/Resized/";
        private readonly string iconpath = "-logo-transparent.png";
        private readonly string fontpath = "-logo-font.png";

        //Use the abbreviated form of the team name as the ID
        public string ID { get; set; }
        
        //Lookup the team's record from the database (or local binding); or set from an admin page
        public int wins { get; set; }
        public int losses { get; set; }
        
        //Use team abbreviations to look-up the full team names, which are part of the img src strings
        //**Replace this with database column that fulfills the need of this property**
        public string teamname 
        {
            get 
            {
                switch (ID)
                {
                    case "AZ":
                        return "arizona-cardinals";
                    case "ATL":
                        return "atlanta-falcons";
                    case "BAL":
                        return "baltimore-ravens";
                    case "BUF":
                        return "buffalo-bills";
                    case "CAR":
                        return "carolina-panthers";
                    case "CHI":
                        return "chicago-bears";
                    case "CIN":
                        return "cincinnati-bengals";
                    case "CLE":
                        return "cleveland-browns";
                    case "DAL":
                        return "dallas-cowboys";
                    case "DEN":
                        return "denver-broncos";
                    case "DET":
                        return "detroit-lions";
                    case "GB":
                        return "green-bay-packers";
                    case "HOU":
                        return "houston-texans";
                    case "IND":
                        return "indianapolis-colts";
                    case "JAX":
                        return "jacksonville-jaguars";
                    case "KC":
                        return "kansas-city-chiefs";
                    case "LAC":
                        return "los-angeles-chargers";
                    case "LAR":
                        return "los-angeles-rams";
                    case "MIA":
                        return "miami-dolphins";
                    case "MIN":
                        return "minnesota-vikings";
                    case "NE":
                        return "new-england-patriots";
                    case "NO":
                        return "new-orleans-saints";
                    case "NYG":
                        return "new-york-giants";
                    case "NYJ":
                        return "new-york-jets";
                    case "OAK":
                        return "oakland-raiders";
                    case "PHI":
                        return "philadelphia-eagles";
                    case "PIT":
                        return "pittsburgh-steelers";
                    case "SF":
                        return "san-francisco-49ers";
                    case "SEA":
                        return "seattle-seahawks";
                    case "TB":
                        return "tampa-bay-buccaneers";
                    case "TEN":
                        return "tennessee-titans";
                    case "WAS":
                        return "washington-redskins";
                    default:
                        return null;
                }  
            }
        }
        //Build the img src path strings from the team names and fixed path roots and suffixes
        public string logoImgSrc 
        {
            get 
            {
                return string.Format(imgpathroot + /*teamname + "/" +*/ teamname + iconpath);
            } 
        }
        public string teamNameImgSrc
        {
            get
            {
                return string.Format(imgpathroot  + /*teamname + "/" +*/ teamname + fontpath);
            }

        }
        //public double aspectRatio;

        //public static Bitmap LoadOriginalImage (string logoImgSrc)
    }
}
