// Part A: Sequences

let x = seq { 1 .. 100 }
// val x : seq<int>

// print all in sequence
let printsq sequence = 
  Seq.iter (fun i -> printf "%d" i) sequence
  
// create a function to generate a sequence of numbers
// yield! keyword includes a sequence of elements into another sequence.
let rec genSeq lower upper = 
  seq {if lower <= upper then
    yield lower;
    yield! genSeq (lower + 1) upper}
  
// write a function that will return an infinite sequence of powers of 2,
// starting from some initial power of 2.
let rec infinitePow num =
  seq {
      yield num;
      yield! infinitePow (num * 2) }

// write an expression to print out the first 10 elements of this sequence.
let printTen sequence =
  printsq (Seq.take 10 sequence)

// Part B: .NET interop

// create a random number generator:
let random = new System.Random(42)

// use this to generate a number between 0 and 100.
let rec genRandom =
  let num = random
  if num <= 100 && num >= 1 then
    num
  else
    genRandom
    