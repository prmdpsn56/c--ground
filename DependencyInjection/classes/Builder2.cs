using DependencyInjection.interfaces;

namespace DependencyInjection.Classes
{
    public class Builder2
    {   

        public ITool Tool { get; set; } 


        public void useTheGiven()
        {
            Tool.useTool();
        }

    }
}