using Acme.StudentStore.Students;
using AutoMapper;

namespace Acme.StudentStore
{
    public class StudentStoreApplicationAutoMapperProfile : Profile
    {
        public StudentStoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Student, StudentDto>();
            CreateMap<CreateUpdateStudentDto, Student>();
        }
    }
}
