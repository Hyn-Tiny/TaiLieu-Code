#include<iostream>
#include<fstream>
#include<string>
#include<string.h>
#include<stdio.h>
using namespace std;
class MATHANG
{
  private:
    char tenMH[50];
    int soLuong;
    float gia;
  public:
    void nhap(const char *tenMH,int soLuong,float gia);
    void xuat();
    float tinhTong();
};
int main() {
  ifstream fin("mathang.txt");
  int n,soluong=0;
  float gia=0;
  float tong=0;
  char tenMH[50];
  

  fin>>n;

  MATHANG *a=new MATHANG[n];

  for(int i=0;i<n;i++){
    cout<<"\n\nmat hang "<<i<<endl;;
    cout<<"\nten mat hang: ";fin.getline(tenMH,sizeof(tenMH));
    cout<<"\nso luong:";fin>>soluong;
    cout<<"\ngia thanh:";fin>>gia;
    a[i].nhap(tenMH,soluong,gia);
    tong+=a[i].tinhTong();
  }
  for(int i=0;i<n;i++){
    a[i].xuat();
  }
  tong+=tong;
  cout<<"tong 3 sản pham là"<<" "<<tong/n;  
  return 0;
}

void MATHANG::nhap(const char *tenMH,int soLuong,float gia)
{
  strcpy(this->tenMH,tenMH);
  this->soLuong=soLuong;
  this->gia=gia;
}

void MATHANG::xuat()
{
  cout<<"\n\ndua ra ten hang"<<tenMH<<endl;
  cout<<"dua ra so luong "<<soLuong<<endl;
  cout<<"dua ra gia mathang "<<gia<<endl;
  cout<<"\ntong "<<tinhTong()<<endl;
}

float MATHANG::tinhTong()
{
  return soLuong*gia;
}

