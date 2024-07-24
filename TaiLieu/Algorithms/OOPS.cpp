#include <iostream>
using namespace std;


//Compiler version g++ 6.3.0
class stack{
  private:
    enum{size=10};
    int T;
    int s[size];
  public:
    void Push(int x);
    int Pop();
    int  IsEmpty();
};


//int Top(stack nx);

int main()
{
    stack nx;
    int n1,thuong;
    cout<<"nhap so";
    cin>>n1;
    thuong=n1;
    while(thuong){
      nx.Push(thuong%2);
      thuong/=2;
    }
    cout<<"ket quả là "<<n1<<endl;
    while(!nx.IsEmpty()){
      cout<<nx.Pop();
    }
    cout <<"Hello, Dcoder!";
    return 0;
}


void stack::Push(int x){
    if(T=size){
      cout<<"ngăn xếp đây"<<endl;
      return;
    }
    T++;
    s[T]=x;
}
int stack:: Pop(){
  if(T==-1){
    cout<<"ngăn xep rông"<<endl;
    return -1;
  }
  return s[T--];
  
}
int stack::IsEmpty(){
  if(T==-1){
    return -1;
    }
    return 0;
  }
 /* int Top(stack nx){
    if(nx.T==-1){
      cout<<"ngan xep rỗng"<<endl;
      return -1;
    }
    return nx.s[nx.T];
  }*/