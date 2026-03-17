using ClinicDesk.Database.Models;

namespace ClinicDesk.Database.Dto;

internal record AppointmentStat(AppointmentStatus Status, int Count);