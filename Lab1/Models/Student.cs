using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên")]
        [StringLength(100, MinimumLength = 4, 
            ErrorMessage = "Bạn cần nhập tên có độ dài từ 4-100 kí tự")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập email")]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@gmail\.com$",
            ErrorMessage = "Bạn cần nhập email có đuôi là @gmail.com")]
        public string? Email {  get; set; }

        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$",
            ErrorMessage = "Mật khẩu của bạn phải từ 8 ký tự trở lên, có ít nhất một chữ cái viết hoa, một chữ cái viết thường, một chữ số và một ký tự đặc biệt.")]
        [Required(ErrorMessage = "Bạn phải nhập password")]
        public string? Password {  get; set; }


        [Required(ErrorMessage = "Bạn cần nhập Branch")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Bạn chọn nhập giới tính")]
        public Gender? Gender { get; set; }

        public bool IsRegular {  get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Bạn cần nhập địa chỉ")]
        public string? Address {  get; set; }

        [Range(typeof(DateTime), "1/1/1920", "12/31/2023", 
            ErrorMessage = "Ngày sinh cần phải nằm trong khoảng thời gian từ 01/01/1920 đến 31/12/2023")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Bạn phải nhập ngày sinh")]
        public DateTime DateOfBorth { get; set; }

        [Range(typeof(double), "0.0", "10.0", 
            ErrorMessage = "Bạn cần nhập điểm trong khoảng 0 - 10 theo kiểu số thực, lấy một chữ số thập phân đằng sau")]
        // đùng data type
        [Required(ErrorMessage = "Bạn cần nhập điểm")]
        public double? Diem { get; set; }
    }
}
