// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using System;

static string[] arr_from_str(string input_str, string sep=" ") {
    string regex_pattern_str = $"[^({sep})]+"; 
    Regex regex_pattern = new Regex(regex_pattern_str);
    MatchCollection words_in_input = regex_pattern.Matches(input_str);
    int regex_match_number = words_in_input.Count;
    string[] result_arr = new string[regex_match_number];
    for (int i = 0 ; i < regex_match_number ; i++) {
        result_arr[i] = words_in_input[i].Value;
    }
    return result_arr;
}

string arr_input = Console.ReadLine();
Console.WriteLine(string.Join(" ", arr_from_str(arr_input)));
