namespace Shop2.Common
{
    public static class Pagination
    {
        public static IEnumerable<TSourse> ToPaged<TSourse>(this IEnumerable<TSourse> sourse,int page,int pageSize,out int rowsCount)
        {
            rowsCount=sourse.Count();
            return sourse.Skip((page-1)*pageSize).Take(pageSize);
        }
    }
}
