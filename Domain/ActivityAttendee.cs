namespace Domain
{
    public class ActivityAttendee
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid ActivitiyId { get; set; }
        public Activity Activity { get; set; }
        public bool IsHost { get; set; }

    }
}