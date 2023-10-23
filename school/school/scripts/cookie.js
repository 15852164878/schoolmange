function setCookie(name,value,day){
       var oDate=new Date();
      oDate.setDate(oDate.getDate()+day);
      document.cookie=name+"=" + value +";expires="+oDate;
}
   setCookie("name1","honny1",1);
   setCookie("name2", "honny2", 1);

  console.log(document.cookie);

   function getCookie(name){
            var str=document.cookie;
           var arr=str.split(";");
          for(var i=0; i<arr.length; i++){
             var  arr1=arr[i].split("=");
             if(arr1[0]==name){
                 return arr1[1];
}
}

}
     console.log(getCookie("name2"));
 
  
     function removeCookie(name){
    setCookie(name,1,-1);
 }
 
     removeCookie("name1");
 console.log(getCookie("name1"));
