namespace SchoolHRAdministration
{
    public class FactoryPattern<K, T> where T : class, K, new()
    {
        public static K GetInstance()
        {
            K ObjK;
            ObjK = new T();
            return ObjK;
        }
    }
}
