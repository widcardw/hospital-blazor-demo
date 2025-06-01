using System.ComponentModel.DataAnnotations;

namespace HospitalApp.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "姓名是必填项")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "年龄是必填项")]
        [Range(0, 150, ErrorMessage = "年龄必须在 0 到 150 之间")]
        public int Age { get; set; }

        [Required(ErrorMessage = "性别是必填项")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "症状是必填项")]
        public string Symptoms { get; set; } = string.Empty;

        [Required(ErrorMessage = "药方是必填项")]
        public string Prescription { get; set; } = string.Empty;
    }
}
