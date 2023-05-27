using System;

public class RandomScripture
{
    private List<Scripture> _scripts = new List<Scripture>()
    {
        new Scripture(new Reference("Proverbs", "3", "5", "6"),"Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
        new Scripture(new Reference("Genesis", "1", "1", "3"),"In the beginning God created the heaven and the earth. And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters. And God said, Let there be light: and there was light."),
        new Scripture(new Reference("Exodus", "2", "15", "16"),"Now when Pharaoh heard this thing, he sought to slay Moses. But Moses fled from the face of Pharaoh, and dwelt in the land of Midian: and he sat down by a well. Now the priest of Midian had seven daughters: and they came and drew water, and filled the troughs to water their father's flock."),
        new Scripture(new Reference("Leviticus", "3", "1", "2"),"And if his oblation be a sacrifice of peace offering, if he offer it of the herd; whether it be a male or female, he shall offer it without blemish before the Lord. And he shall lay his hand upon the head of his offering, and kill it at the door of the tabernacle of the congregation: and Aaron's sons the priests shall sprinkle the blood upon the altar round about."),
        new Scripture(new Reference("Matthew", "24", "35"),"Heaven and earth shall pass away, but my words shall not pass away."),
    };
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scripts.Count);
        return _scripts[index];
    }
}