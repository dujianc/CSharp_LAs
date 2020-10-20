using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingFundamentals
{
    public class VHSTape
    {
        public string Name { get; set; }
        public bool Rented { get; set; }
        public float Progress { get; set; }
        public float Duration { get; set; }

        public VHSTape(string name, float length)
        {
            Name = name;
            Duration = length;
            Rented = false;
            Progress = 0.0f;
        }

        public void Play(float duration)
        {
            Progress += duration;
            if (Progress > Duration)
            {
                Progress = Duration;

            }
        }

        public void Rewind(float duration)
        {
            Progress -= duration;
            if (Progress < 0)
            {
                Progress = 0;

            }
        }

        public bool IsRented()
        {
            return Rented;
        }

        public class Blockbuster
        {
            public string Address;
            public List<VHSTape> Movies;

            public Blockbuster(string storeAddress)
            {
                Address = storeAddress;
                Movies = new List<VHSTape>();
            }

            public void AddMovie(VHSTape tape)
            {
                Movies.Add(tape);
            }

            public bool HasMovie(string name)
            {
                VHSTape tape = Movies.Find(a => a.Name == name);
                if (tape == null)
                {
                    return false;
                }
                return true;
            }

            public bool IsMovieAvailable(string name)
            {
                VHSTape tape = Movies.Find(a => a.Name == name);
                if (tape == null)
                {
                    return false;
                }
                else
                {
                    if (tape.Rented == false)
                        return true;
                }
                return false;
            }

            public VHSTape Rent(string name)
            {
                VHSTape tape = Movies.Find(a => a.Name == name);
                if (tape == null) return null;
                else if (tape.IsRented() == false)
                {
                    tape.Rented = true;
                    return tape;
                }

                return null;
            }

            public VHSTape GetRented(string name)
            {
                VHSTape tape = Movies.Find(a => a.Name == name);
                if (tape == null) return null;
                else if (tape.IsRented() == true)
                {
                    return tape;
                }

                return null;
            }

            public void Return(string name)
            {
                VHSTape tape = Movies.Find(a => a.Name == name);
                if (tape.IsRented() == true)
                {
                    tape.Rented = false;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var store = new Blockbuster("Calgary, Alberta, Canada.");
                string command = "";
                while (command != "exit")
                {
                    command = Console.ReadLine();
                    var cmdArgs = command.Split();
                    if (cmdArgs.Length == 0)
                        continue;
                    if (cmdArgs[0] == "add")
                    {
                        var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                        var length = float.Parse(cmdArgs.Last());
                        var tape = new VHSTape(name, length);
                        store.AddMovie(tape);
                    }
                    else if (cmdArgs[0] == "find")
                    {
                        var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                        bool hasMovie = store.HasMovie(name);
                        if (hasMovie)
                            Console.WriteLine("Store has " + name);
                        else
                            Console.WriteLine("Store does not have " + name);
                    }
                    else if (cmdArgs[0] == "available")
                    {
                        var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                        bool available = store.IsMovieAvailable(name);
                        if (available)
                            Console.WriteLine(name + " is available");
                        else
                            Console.WriteLine(name + " is rented");
                    }
                    else if (cmdArgs[0] == "rent")
                    {
                        var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                        VHSTape movie = store.Rent(name);
                        Console.WriteLine(name + ": " + (movie.Rented ? "rented" : "available"));
                    }
                    else if (cmdArgs[0] == "play")
                    {
                        var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                        var duration = float.Parse(cmdArgs.Last());
                        var movie = store.GetRented(name);
                        movie.Play(duration);
                        Console.WriteLine(movie.Name + ": " + movie.Progress);
                    }
                    else if (cmdArgs[0] == "rewind")
                    {
                        var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 2));
                        var duration = float.Parse(cmdArgs.Last());
                        var movie = store.GetRented(name);
                        movie.Rewind(duration);
                        Console.WriteLine(movie.Name + ": " + movie.Progress);
                    }
                    else if (cmdArgs[0] == "return")
                    {
                        var name = string.Join(" ", cmdArgs.Skip(1).Take(cmdArgs.Length - 1));
                        var movie = store.GetRented(name);
                        store.Return(name);
                        Console.WriteLine(name + ": " + (movie.Rented ? "rented" : "available"));
                    }
                }
            }
        }
    }
}

