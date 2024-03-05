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

static string[] limit_to_x_chars(string[] str_arr, int limit) {
    /*
     * Returns array of strings from str_arr that have less or x/limit chars
     */
    string[] result_arr = new string[str_arr.Length];
    // I must use arrs so I have to use this
    int result_arr_occupied = 0;
    for (int i = 0 ; i < str_arr.Length ; i++) {
        if (str_arr[i].Length <= limit) {
            result_arr[result_arr_occupied] = str_arr[i];
            result_arr_occupied++;
        }
    }
    return result_arr;
}

string arr_input = Console.ReadLine();
string[] formatted_array = limit_to_x_chars(arr_from_str(arr_input), 3);
Console.WriteLine(string.Join(" ", formatted_array));
