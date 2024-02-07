using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PTrucks.Models
{

    [Table("Location")]
    public class DeviceLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationID { get; set; }

        [Required]
        [StringLength(20)]
        public string MacAddress { get; set; }

        [Required]
        [StringLength(5)]
        public string DeviceRSSI { get; set; }

        [Required]
        public int DeviceVoltage { get; set; }

        [Required]
        public int SatelliteCount { get; set; }

        [Required]
        [StringLength(12)]
        public string Latitude { get; set; }

        [Required]
        [StringLength(12)]
        public string Longitude { get; set; }

        [Required]
        public int Chassis { get; set; }

        public DateTime? LastHeardDate { get; set; }
    }

}
