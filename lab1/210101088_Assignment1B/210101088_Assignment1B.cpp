#include <bits/stdc++.h>
using namespace std;
float limit_max = 1e9;
float limit_min = -1e9;

float calculator(float a, float b, char opern)
{
    float ans;
    switch (opern)
    {
    case '+':
        ans = a + b;
        break;

    case '-':
        ans = a - b;
        break;

    case '*':
        ans = a * b;
        break;

    case '/':
        ans = a / b;
        break;
    }

    return ans;
}

int main()
{
    float a, b;
    string a1, b1;
    cout << "Type 'exit' to quit. Enter 2 numbers between 1e9 and -1e9:\n";

    while (true)
    {
        cout << "Enter 1st number= ";
        cin >> a1;
        if (a1.compare("exit") == 0)
        {
            cout << "\nUser wished to quit.\n";
            return 0;
        }
        try
        {
            a = stof(a1);
        }
        catch (const invalid_argument &e)
        {
            cerr << "Invalid argument: " << e.what() << endl;
        }
        catch (const out_of_range &e)
        {
            cerr << "Out of range: " << e.what() << endl;
        }
        if (a > limit_max || a < limit_min)
        {
            cout << "Beyond calculation scope" << endl;
            return 0;
        }

        char opern;
        string opern1;
        cout << "Enter one of the operations {+,-,*,/} : ";
        cin >> opern1;
        if (opern1.compare("exit") == 0)
        {
            cout << "\nUser wished to quit.\n";
            return 0;
        }

        if (opern1.length() != 1)
        {
            cout << "Invalid operator.\n";
            return 0;
        }
        else
        {
            opern = opern1[0];
            if (!(opern == '+' || opern == '-' || opern == '*' || opern == '/'))
            {
                cout << "Invalid operator.\n";
                return 0;
            }
        }

        cout << "Enter 2nd number= ";
        cin >> b1;
        if (b1.compare("exit") == 0)
        {
            cout << "\nUser wished to quit.\n";
            return 0;
        }
        try
        {
            b = stof(b1);
        }
        catch (const invalid_argument &e)
        {
            cerr << "Invalid argument: " << e.what() << endl;
        }
        catch (const out_of_range &e)
        {
            cerr << "Out of range: " << e.what() << endl;
        }
        if (b > limit_max || b < limit_min)
        {
            cout << "Beyond calculation scope" << endl;
            return 0;
        }

        // division by zero
        if (b == 0 && opern == '/')
        {
            cout << "Divide by 0 not allowed." << endl;
            return 0;
        }

        float ans = calculator(a, b, opern);
        if (ans > limit_max || ans < limit_min)
        {
            cout << "Beyond calculation scope" << endl;
            return 0;
        }
        else
        {
            cout << "Answer= " << ans << endl;
        }
    }
}