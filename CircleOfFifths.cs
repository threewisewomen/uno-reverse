using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uno_reverse
{
    public enum MusicalNotes
    {
        C,
        CSharp,
        D,
        DSharp,
        E,
        F,
        FSharp,
        G,
        GSharp,
        A,
        ASharp,
        B,

    }
    public class CircleOfFifths
    {
        private static readonly int NoteCount = Enum.GetNames(typeof(MusicalNotes)).Length;
        private static MusicalNotes GetNextNote(MusicalNotes currentNote)
        {
            int currentIndex = (int)currentNote;
            int nextIndex = (currentIndex + 2) % NoteCount;
            return (MusicalNotes)nextIndex;
        }
        public static MusicalNotes GetPerfectFifth(MusicalNotes note)
        {
            int currentIndex = (int)note;
            int perfectFifthIndex = (currentIndex + 7) % NoteCount;
            return (MusicalNotes)perfectFifthIndex;
        }
        public static MusicalNotes GetPerfectFourth(MusicalNotes note)
        {
            int currentIndex = (int)note;
            int perfectFourthIndex = (currentIndex + 5) % NoteCount;
            return (MusicalNotes)perfectFourthIndex;
        }

        public void CircleOfFifthsMain()
        {
            Console.WriteLine("Circle of Fifths:");
            foreach (MusicalNotes note in Enum.GetValues(typeof(MusicalNotes)))
            {
                Console.WriteLine("__________________________");
                Console.WriteLine($"{note} -> {GetPerfectFifth(note)}");
            }
            Console.WriteLine("************************");

            Console.WriteLine("\nCircle of Fourths:");
            foreach (MusicalNotes note in Enum.GetValues(typeof(MusicalNotes)))
            {
                Console.WriteLine("__________________________");
                Console.WriteLine($"{note} -> {GetPerfectFourth(note)}");
            }
        }
    }
}
