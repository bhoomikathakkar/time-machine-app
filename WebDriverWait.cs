using System;

namespace Desktop_Demo
{
    internal class WebDriverWait
    {
        private object windriver;
        private TimeSpan timeSpan;

        public WebDriverWait(object windriver, TimeSpan timeSpan)
        {
            this.windriver = windriver;
            this.timeSpan = timeSpan;
        }
    }
}