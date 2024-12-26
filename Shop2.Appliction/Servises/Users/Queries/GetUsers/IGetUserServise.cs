namespace Shop2.Appliction.Servises.Users.Queries.GetUsers
{
    public interface IGetUserServise
    {
        List<GetUsersDto> Execute(RequestGetUserDto request);
    }
}
