using System.Collections.Immutable;

namespace JackHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImmutableList<string> initialPoem = ImmutableList<string>.Empty;

            Part1 part1 = new Part1();
            Part2 part2 = new Part2();
            Part3 part3 = new Part3();
            Part4 part4 = new Part4();
            Part5 part5 = new Part5();
            Part6 part6 = new Part6();
            Part7 part7 = new Part7();
            Part8 part8 = new Part8();
            Part9 part9 = new Part9();

            part9.AddPart(
                part8.AddPart(
                    part7.AddPart(
                        part6.AddPart(
                            part5.AddPart(
                                part4.AddPart(
                                    part3.AddPart(
                                        part2.AddPart(
                                            part1.AddPart(
                                                initialPoem
                                                )))))))));

            PrintPoem(part1.Poem, "Part1");
            PrintPoem(part2.Poem, "Part2");
            PrintPoem(part3.Poem, "Part3");
            PrintPoem(part4.Poem, "Part4");
            PrintPoem(part5.Poem, "Part5");
            PrintPoem(part6.Poem, "Part6");
            PrintPoem(part7.Poem, "Part7");
            PrintPoem(part8.Poem, "Part8");
            PrintPoem(part9.Poem, "Part9");
        }

        static void PrintPoem(ImmutableList<string> poem, string partName)
        {
            Console.WriteLine($"{partName}:");
            foreach (var line in poem)
                Console.WriteLine(line);
            Console.WriteLine();
        }
    }

    abstract class PoemPart
    {
        public ImmutableList<string> Poem { get; protected set; }

        protected PoemPart()
        {
            Poem = ImmutableList<string>.Empty;
        }

        public abstract ImmutableList<string> AddPart(ImmutableList<string> previousPoem);
    }

    class Part1 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("Вот дом,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part2 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("А это пшеница,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part3 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("А это веселая птица-синица,")
                .Add("Которая часто ворует пшеницу,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part4 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("Вот кот,")
                .Add("Который пугает и ловит синицу,")
                .Add("Которая часто ворует пшеницу,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part5 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("Вот пес без хвоста,")
                .Add("Который за шиворот треплет кота,")
                .Add("Который пугает и ловит синицу,")
                .Add("Которая часто ворует пшеницу,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part6 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("А это корова безрогая,")
                .Add("Лягнувшая старого пса без хвоста,")
                .Add("Который за шиворот треплет кота,")
                .Add("Который пугает и ловит синицу,")
                .Add("Которая часто ворует пшеницу,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part7 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("А это старушка, седая и строгая,")
                .Add("Которая доит корову безрогую,")
                .Add("Лягнувшую старого пса без хвоста,")
                .Add("Который за шиворот треплет кота,")
                .Add("Который пугает и ловит синицу,")
                .Add("Которая часто ворует пшеницу,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part8 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("А это ленивый и толстый пастух,")
                .Add("Который бранится с коровницей строгою,")
                .Add("Которая доит корову безрогую,")
                .Add("Лягнувшую старого пса без хвоста,")
                .Add("Который за шиворот треплет кота,")
                .Add("Который пугает и ловит синицу,")
                .Add("Которая часто ворует пшеницу,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }

    class Part9 : PoemPart
    {
        public override ImmutableList<string> AddPart(ImmutableList<string> previousPoem)
        {
            Poem = previousPoem
                .Add("Вот два петуха,")
                .Add("Которые будят того пастуха,")
                .Add("Который бранится с коровницей строгою,")
                .Add("Которая доит корову безрогую,")
                .Add("Лягнувшую старого пса без хвоста,")
                .Add("Который за шиворот треплет кота,")
                .Add("Который пугает и ловит синицу,")
                .Add("Которая часто ворует пшеницу,")
                .Add("Которая в темном чулане хранится")
                .Add("В доме,")
                .Add("Который построил Джек.");

            return Poem;
        }
    }
}