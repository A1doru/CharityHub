namespace TestConsole.TaskNew
{
    class TaskDirector
    {
        private TaskBuilder _taskBuilder;

        public TaskDirector()
        {
            _taskBuilder = new TaskBuilder();
        }

        public TaskBase CreateNewTask(string typeTask)
        {

            if(typeTask == "social")
            {
                return _taskBuilder.CreateSocialActivity();
            }
            else
            {
                return null;
            }
        }
    }
}
