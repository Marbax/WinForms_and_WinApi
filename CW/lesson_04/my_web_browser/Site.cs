
namespace my_web_browser
{
    public class Site
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        /// <summary>
        /// Automaticaly became as foreign key
        /// </summary>
        public int Category_Id { get; set; }

        public virtual Category Category { get; set; }


    }
}
