#include <iostream>
using namespace std;
void sapXepChon(int a[50], int &n){
    for(int i=0; i<n-1;i++){
        int mini=i;
        for(int j=i+1;j<n;j++){
            if(a[j]<a[mini]){
               mini=j;
            }
        }
        int temp=a[i];
        a[i]=a[mini];
        a[mini]=temp;
    }
}

void sapXepNoiBot(int a[50],int &n){
    for(int i=0;i<n-1;i++){
        for(int j=0;j<n-i-1;j++){
            if(a[j]>a[j]+1){
                int temp=a[j];
                a[j]=a[j+1];
                a[j+1]=temp;
            }
        }
    }
}

void tk(SinhVien a[50], int n , int k){
  int i =0;
  while(){
    
  }
}
int main() {
    int a[50],n;
    cout<<"nhap so ";
    cin>>n;
    cout<<n<<endl;
    for(int i=0;i<n;i++){
        cout<<"a["<<i<<"]= ";
        cin>>a[i];
        cout<<a[i]<<endl;
    }
    cout<<"\n day so chua sap xep ";
    for(int i=0;i<n;i++){
        cout<<a[i]<<" ";
        }
        
        
    cout<<"\nday so su dung sap xep chon ";
    sapXepChon (a,n);
    for(int i=0;i<n;i++){
        cout<<a[i]<<" ";
    }
    
    cout<<" \n day so su dung sap xep noi bot ";
    sapXepNoiBot(a,n);
    for(int i=0;i<n;i++){
        cout<<a[i]<<" ";
    }
    cout<<"\n day so su dung sap xep chen  ";
    sapXepChen (a,n);
    for(int i=0;i<n;i++){
        cout<<a[i]<<" ";
    }
    
    return 0;
}