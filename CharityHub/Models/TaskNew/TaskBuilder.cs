using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.TaskNew
{
    class TaskBuilder
    {

        public TaskBase CreateSocialActivity()
        {
            TaskBase social = new SocialActivity();
            return social;
        }

        public TaskBase CreateFundRaising()
        {
            return null;
        }

        public TaskBase CreatePhysicalActivity()
        {
            return null;
        }
    }
}
