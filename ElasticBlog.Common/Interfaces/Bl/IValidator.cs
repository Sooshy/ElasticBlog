namespace ElasticBlog.Common.Interfaces.Bl
{
    public interface IValidator<in T>

    {
        bool Validate(T data);
    }
}