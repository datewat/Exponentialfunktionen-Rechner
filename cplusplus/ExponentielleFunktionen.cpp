#include <iostream>
#include <cmath>

using namespace std;
int main(){
int c;
int x;
int x1;
float a;

cout <<"Startwert auf der Y Achse(c):\n";
cin >> c ;
cout << "Wachstumsfaktor (a):\n";
cin >> a;
cout << "Start-X (im Kordinatensystem):\n";
cin >> x;
cout <<"Ende-X(im Kordinatensystem, Zeit):\n";
cin >> x1;
x1 = x1 + 1;
double ergebnis = c*a;

for (int y = 0; x <  x1; x++)
                {
                    cout << "S(" << x <<"|"<<  pow (ergebnis, x) <<")\n" ;



                }
cout << "\n";
cout << "\n";
cout << "\n";
}
