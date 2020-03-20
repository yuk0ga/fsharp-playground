// initialize list
let newList = [1;2;3;4;5]

// get length
let getLength (list: 'T list) : int = 
  list.Length

// find average
let avg list : int = 
  List.reduce (+) list / getLength list


// reverse a list
let rec reverse list = 
  match list with
  | [] -> []
  | head::tail -> reverse tail @ [head]

 // head: 1, tail: [2;3;4;5]
 // head: 2, tail: [3;4;5]
 // head: 3, tail: [4;5]
 // head: 4, tail: [5]
 // head: 5, tail: []

 // find the last element of a list
let rec getLastElem (list: 'T list) =
  let reversed = reverse list
  reversed.[0]

// find the kth element of a list
let rec getElement (list:'T list) k =
  list.[k]

// flatten a list of lists into a list
let listOfLists = [[1;2;3];[4;5;6];[7;8;9]]
let rec flatten list =
  match list with
  | [] -> []
  | head::tail -> head @ flatten tail

// eliminate duplicates in a list
let rec removeDuplicates list =
  match list with
  | [] -> []
  | head::tail -> 
    if (List.contains head tail) then (removeDuplicates tail) else list

// Find out if a list is a palindrome
let rec isPalindrome list = 
  match list with
  | [] -> true
  | head::tail -> 
    if List.isEmpty tail then
      true
    else 
      if (head = getElement (reverse tail) 0) then 
        match (reverse tail) with
        | [] -> true
        | _::t -> isPalindrome (reverse t)
      else 
        false

// Sort the elements of a list
let sort list = List.sort list
    

// Assignment 1
//set WPFView as Startup project
      
// Represent a sorted binary tree in F# (binary search tree)
TODO

// Determine if a particular element is already in the tree
TODO

// Use Higher order List functions to:
// add 3 to each of the elements of a list
let rec addThree f list =
  match list with
  | [] -> []
  | head::tail -> (f head) :: (addThree f tail)

addThree (fun x -> x + 3) newList

// find all of the elements in a list which are greater than 3
let rec findGreaterThanThree f list =
  match list with
  | [] -> []
  | head::tail -> 
    if (f head) then
      head :: (findGreaterThanThree f tail)
    else
      findGreaterThanThree f tail
  
findGreaterThanThree (fun x -> x > 3) newList

// Multiply together all of the elements of a list
List.reduce (*) newList;;

// Determine if all of the elements in a list are positive
let rec allPositive f list =
  match list with
  | [] -> []
  | head::tail -> f head :: (allPositive f tail)

List.reduce (||) (allPositive (fun x -> x > 0) newList);;

// Count the number of negative elements in a list
let rec countNegative f list =
  match list with
  | [] -> []
  | head::tail -> f head :: (countNegative f tail)

List.reduce (+) (countNegative (fun x -> if x < 0 then 1 else 0) newList);;