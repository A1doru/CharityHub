using System.Text.RegularExpressions;

namespace TestConsole.TaskNew
{
    class SocialActivity : TaskBase
    {
        public string Link { get; set; }

        public void SetLink(string link)
        {
            string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            if(regex.IsMatch(link))
            {
                Link = link;
            }
        }

        public SocialActivity()
        {
            
        }
    }
}
