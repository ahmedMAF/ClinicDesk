using ClinicDesk.Database.Models;

namespace ClinicDesk.Database.Dto;

public record AppointmentStat(AppointmentStatus Status, int Count);