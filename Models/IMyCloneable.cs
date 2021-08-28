namespace Otus30.Models
{
    public interface IMyCloneable<out T>
    {
        public T MyClone();
    }
}