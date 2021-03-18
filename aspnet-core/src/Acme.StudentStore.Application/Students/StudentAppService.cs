using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentStore.Students
{
    public class StudentAppService :
        CrudAppService<
            Student, //The Book entity
            StudentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStudentDto>, //Used to create/update a book
        IStudentAppService //implement 
    {
        public StudentAppService(IRepository<Student,Guid> repository) : base(repository)
        {

        }
    }
}
