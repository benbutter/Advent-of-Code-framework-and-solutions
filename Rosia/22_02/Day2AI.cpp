// I got the openai ai to write the solution
//  to this problem, here is its solution:
#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main() {
  // Prompt the user to enter the input string
  cout << "Enter a string of letters: ";

  // Initialize the sum of the numeric values of the common letters to zero
  int sum = 0;

  // Read each line of input
  string line;
  while (getline(cin, line)) {
    // Check if the end of the input has been reached
    if (cin.eof()) {
      // If the end of the input has been reached, print the sum of the numeric values of the common letters
      cout << "The sum of the numeric values of the common letters is: " << sum << endl;
      return 0;
    }

    // Find the length of the string
    int n = line.length();

    // Since the length of the string is assumed to be even, we can simply
    // get the first half of the string by taking the first n / 2 characters
    string firstHalf = line.substr(0, n / 2);

    // Similarly, we can get the second half of the string by taking the last n / 2 characters
    string secondHalf = line.substr(n / 2, n / 2);

    // Loop through each character in the first half of the string
    for (char c : firstHalf) {
      // Check if the character appears in the second half of the string
      if (secondHalf.find(c) != string::npos) {
        // If the character appears in the second half, it is the common letter

        // Calculate the numeric value of the common letter
        if (isalpha(c)) {
          if (islower(c)) {
            // If the letter is lowercase, its numeric value is its position in the alphabet (1-26)
            sum += c - 'a' + 1;
          } else {
            // If the letter is uppercase, its numeric value is its position in the alphabet plus 26 (27-52)
            sum += c - 'A' + 27;
          }
        }
      }
    }
  }

  return 0;
}