using My_First_Project.DTOs.Requests;
using My_First_Project.DTOs.Responces;

namespace My_First_Project.Services.StudentService
{
    public interface IStudentService
    {
        BaseResponse CreateStudent(CreateStudentRequest request);

        BaseResponse StudentList();

        BaseResponse GetStudentById(long id);

        BaseResponse UpdateStudentById(long id, UpdateStudentRequest request);

        BaseResponse DeleteStudentById(long id);
    }
}
