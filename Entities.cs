using System;

public class Event

    public Event()
	{

        [Key]
        public int IdEvent { get; set; }

        public int IdStation { get; set; }

        public int EventType { get; set; }

	}
}
