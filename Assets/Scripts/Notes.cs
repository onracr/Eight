using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Note Data")]
public class Notes : ScriptableObject
{
    public Sprite img_1;
    public Sprite img_2;
    public Sprite img_3;
    public Sprite img_4;

    private object[] notes = new object[8];
    
    private string note_1 = "\t\tI'm falling... In the dark of the night, floating through a dark emptiness like falling down from the\n" +
                            "edge of a cliff without a light which enlightens the path. Suddenly, that pitch-dark leaves its place to a\n" +
                            "deceiving, weak light that the eye is accustomed to darkness.\n" + 
                            "\t\tI have finally arrived to a large cave... I can see the moving surface, which scares me at first but i try not to\n" +
                            "think on that. After that long fall, finally my feet meet the ground. It seems like that crawling ground is a lakelet\n" +
                            "which remained hidden in this cave for a long, long time. That former fear leaves its place to freedom and relief.\n" +
                            "When i've checked my vicinity, a dim flash appears, so i am heading towards there, and encountered with an\n" +
                            "architecture which is probably stayed hidden for centuries.\n" + 
                            "\t\tI want to walk around every room in the area which enchantes me deeply. I take the left room then i see the\n" +
                            "knight's armors and mysterious paintings all around the room. Especially one of the paintings takes my attention;\n" +
                            "a water well in an untouched forest. Lost my perception of time while i am looking at the painting, then time\n" + 
                            "stopped as if i'll become a part of that forest." ;
    
    private string note_2 = "- Why do you want to go there?\n" + 
                            "- You have to crack a few eggs to make an omelette, right?\n" + 
                            "- As you wish. First, you need to know that you can't go there in the daylight. You can imagine there like an" +
                            "ice-cream store just opens at nights.\n" + 
                            "- I see my little friend, let's pet to the point since i have got tones of works to do.\n" + 
                            "- Very well, get out of your cabin. Turn left from your favorite painting and keep walking till you see me.\n\n" + 
                            "\t\tThis was the last talk we made with my little buddy. Don't know who he was or where he came from but\n" + 
                            "surprisingly felt like he was so familiar. I got ready and went out. There was this scent which amazes me\n" + 
                            "since i was a little boy; it must have rained.\n" + 
                            "\t\tI hit the road with the scent of the dirt on my lungs and one crucial question on my mind, turned left from\n" + 
                            "the lonely water well, kept walking and saw my little buddy at the rocky passage where greenary has no place\n" + 
                            "on it. He'd sat on a rock and was drawing something on a piece of paper.";

    private string note_3 = "\t\tI opened my eyes beneath the shadow of a majestic and lonely tree and found myself right in the middle of\n" + 
                            "those floating rocks as if i was still asleep and below of those rocks there was a lake which is trapped in a\n" +
                            "mysterious mist. After i got up and right before i threw myself into the misty waters, i heard a high-pitched\n" + 
                            "noise that came from behind me and was startled.\n" + 
                            "\t\tI had to find the source of that noise and from there i saw the rising smokes when i started to walk away from\n" + 
                            "that misty lake, kept walking for a while till a cave appeared before me and inside it, there was a boy; who'd\n" + 
                            "sat next to the fire; may be he was here to protect himself from the cold that the rain had brought or may be\n" +
                            "he was enjoying to sit by fire just like me.\n" +
                            "\t\tI quietly sat next to him, closed my eyes only for a moment; a song, i loved dearly was playing on my mind\n" +
                            "that i couldn't remember its name and that moment'd gone. Opened my eyes, looked at him; just like me he was\n" + 
                            "looking back to me with a smile on his face. Without saying anything, we kept listening out forgotten song.";
    
    private string note_5 = "All my dreams passed before my eyes..";

    public object[] AddingNotes()
    {
        notes[0] = img_1;
        notes[1] = note_1;
        notes[2] = note_2;
        notes[3] = img_2;
        notes[4] = note_3;
        notes[5] = img_3;
        notes[6] = img_4;
        notes[7] = note_5;

        return notes;
    }
}
