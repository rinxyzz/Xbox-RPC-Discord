#include <fstream>
 std::ifstream infile("thefile.txt");

     int a, b;
     while (infile >> a >> b)
     {
         // process pair (a,b)
     }

     #include <sstream>
     #include <string>

     std::string line;
     while (std::getline(infile, line))
     {
         std::istringstream iss(line);
         int a, b;
         if (!(iss >> a >> b)) { break; } // error

         // process pair (a,b)
     }