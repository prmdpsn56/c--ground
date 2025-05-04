using DependencyInjection.interfaces;

namespace DependencyInjection.Classes
{
    public class Builder
    {   

        private ITool _tool;
        public Builder(ITool tool){
            this._tool = tool;
        }   


        public void useTheGiven()
        {
            _tool.useTool();
        }

    }
}