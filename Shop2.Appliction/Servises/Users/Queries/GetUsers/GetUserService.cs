using Shop2.Appliction.Interfaces.Context;
using Shop2.Common;

namespace Shop2.Appliction.Servises.Users.Queries.GetUsers
{
    public class GetUserService : IGetUserServise
    {
        private readonly IShopContext _ShopContext;
        public GetUserService(IShopContext ShopContext)
        {
            _ShopContext = ShopContext;
        }

        public List<GetUsersDto> Execute(RequestGetUserDto request)
        {
           var users=_ShopContext.Users.AsQueryable();
            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }
            int rowCount = 0;
            return users.ToPaged(request.Page, 20, out rowCount).Select(p=> new GetUsersDto
            {
                FullName = p.FullName,
                Email = p.Email,
                Id = p.Id,
            }).ToList();
        }
    }
}
