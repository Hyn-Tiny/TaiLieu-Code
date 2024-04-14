#include <iostream>
using namespace std;

class PhanSo
{
    private :
    float ts,ms;
    public :
    PhanSo ();
    PhanSo(float ts,float ms);
    
    friend  istream& operator>>(istream &cin,PhanSo &a);
    friend  ostream& operator<<(ostream  &cout, PhanSo a);
    PhanSo operator +(PhanSo &t);
};    

int main() {
  PhanSo a,b,tong;
  
 // cout<<"nhap vao so";
  cin>>a>>b;
  
  tong=a+b;
  
  cout<<a<<b<<endl;
  cout<<tong;
    return 0;
}

PhanSo::PhanSo():ts(0),ms(0)
{}

PhanSo::PhanSo(float ts,float ms):ts(ts),ms(ms)
{}

istream& operator>>(istream &cin,PhanSo &a)
{
    cout<<"nhap so";
    cin>>a.ts>>a.ms;
    return cin;
}
ostream& operator<<(ostream &cout,PhanSo a)
{
    cout<<"tu so ";
    cout<<a.ts<<"/"<<a.ms<<endl;
    return cout;
}
PhanSo PhanSo::operator+(PhanSo &t)
{
  PhanSo to;
  to.ts=ts*t.ms+ms*t.ts;
  to.ms=ms*t.ms;
  return to;
  }