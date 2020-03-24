using ElasticBlog.Common.Interfaces;

namespace ElasticBlog.Common.Models
{
    public class UpdatePost : IUpdateModel
    {
        public string Id
        {
            get => default;
            set
            {
            }
        }

        public int Title
        {
            get => default;
            set
            {
            }
        }

        public int PostText
        {
            get => default;
            set
            {
            }
        }
    }
}