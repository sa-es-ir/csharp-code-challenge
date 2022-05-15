## Description
how to get the longest common prefix from a list of strings {"a","abC","abcD"} would return "ab". Common as in at least 1 other string has it.
Even though "a" is common for all 3, I would like to get "ab" because 2 elements share this prefix and "ab" is longer than "a".


### Examples
- input: ["a", "abC", "abcD"] => "ab"
- input: ["a", "abC", "abcD", "abcz"] => "abc"
- input: ["a", "a4bC", "a1bcD", "a2bcz"] => "a"
