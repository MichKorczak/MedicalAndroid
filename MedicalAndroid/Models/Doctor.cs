using MedicalAndroid.Models.Enums;

namespace MedicalAndroid.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SpecializationList Specialization { get; set; }
    }
}