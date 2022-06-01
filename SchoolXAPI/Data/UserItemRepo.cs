using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolXAPI.Models.User;

namespace SchoolXAPI.Data
{
    public class UserItemRepo
    {
        private readonly MyDbContext _repo;

        public UserItemRepo(MyDbContext repo)
        {
            _repo = repo;
        }

        public DbSet<UserItem> All()
        {
            return _repo.User;
        }

        public Object Query(string type, string search, string sort, int? queryPage)
        {
            var query = (from user
                        in _repo.User
                         select user);
            if (type == "id")
            {

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(p => p.Id.ToString().Contains(search));
                }

                if (sort == "up")
                {
                    query = query.OrderBy(p => p.Id);
                }
                else if (sort == "down")
                {
                    query = query.OrderByDescending(p => p.Id);
                }

            }
            else if (type == "date")
            {

                query = query.Where(p => p.DateCreate.ToString().Contains(search));

                if (sort == "up")
                {
                    query = query.OrderBy(p => p.DateCreate);
                }
                else if (sort == "down")
                {
                    query = query.OrderByDescending(p => p.DateCreate);
                }
            }
                int perPage = 9;
                int page = queryPage.GetValueOrDefault(1) == 0 ? 1 : queryPage.GetValueOrDefault(1);
                var total = query.Count();

                return new
                {
                    data = query.Skip((page - 1) * perPage).Take(perPage),
                    total,
                    page,
                    last_page = total / perPage
                };
            
        }
       
    }
}
    

