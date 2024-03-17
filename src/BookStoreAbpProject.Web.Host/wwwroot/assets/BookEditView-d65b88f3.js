import{n,g as d,d as s,m as r,l as u,b as l,r as c}from"./index-bfafebc5.js";var m=function(){var t=this,i=t.$createElement,e=t._self._c||i;return e("div",{staticClass:"edit"},[e("h2",[t._v("修改图书")]),e("div",{staticClass:"edit-item"},[e("label",[t._v("书名")]),e("input",{directives:[{name:"model",rawName:"v-model",value:t.editData.name,expression:"editData.name"}],attrs:{placeholder:"请输入书名"},domProps:{value:t.editData.name},on:{input:function(a){a.target.composing||t.$set(t.editData,"name",a.target.value)}}})]),e("div",{staticClass:"edit-item"},[e("label",[t._v("作者")]),e("input",{directives:[{name:"model",rawName:"v-model",value:t.editData.author,expression:"editData.author"}],attrs:{type:"text",placeholder:"请输入作者"},domProps:{value:t.editData.author},on:{input:function(a){a.target.composing||t.$set(t.editData,"author",a.target.value)}}})]),e("div",{staticClass:"edit-item"},[e("label",[t._v("出版社")]),e("input",{directives:[{name:"model",rawName:"v-model",value:t.editData.publisher,expression:"editData.publisher"}],attrs:{type:"text",placeholder:"请输入出版社"},domProps:{value:t.editData.publisher},on:{input:function(a){a.target.composing||t.$set(t.editData,"publisher",a.target.value)}}})]),e("div",{staticClass:"edit-item"},[e("label",[t._v("数量")]),e("input",{directives:[{name:"model",rawName:"v-model",value:t.editData.stockNumber,expression:"editData.stockNumber"}],attrs:{type:"number",placeholder:"请输入数量",min:"0",step:"1"},domProps:{value:t.editData.stockNumber},on:{input:function(a){a.target.composing||t.$set(t.editData,"stockNumber",a.target.value)}}})]),e("div",{staticClass:"edit-item"},[e("label",[t._v("单价")]),e("input",{directives:[{name:"model",rawName:"v-model",value:t.editData.price,expression:"editData.price"}],attrs:{type:"number",placeholder:"请输入单价",min:"0",step:"0.01"},domProps:{value:t.editData.price},on:{input:function(a){a.target.composing||t.$set(t.editData,"price",a.target.value)}}})]),e("div",{staticClass:"edit-item"},[e("button",{staticStyle:{width:"100%"},on:{click:t.editBook}},[t._v("修改")])])])},p=[];const v={data(){return{editData:{id:0,price:0,stockNumber:0,publisher:"",name:"",author:""}}},methods:{loadData(t){console.log(t),d("/Book/Get?id="+t).then(i=>{if(!i.success){s("未查询到数据！"+JSON.stringify(i));return}this.editData=i.result})},editBook:function(){if(!this.editData.id){r("数据异常，无法保存！");return}if(!this.editData.name){r("请输入书名！");return}if(!this.editData.author){r("请输入作者！");return}if(!this.editData.publisher){r("请输入出版社！");return}if(!this.editData.stockNumber){r("请输入数量！");return}if(!this.editData.price){r("请输入单价！");return}u(),l("/Book/Update",this.editData).then(t=>{if(!t.success){s("修改图书失败！"+JSON.stringify(t));return}s("修改图书成功！",function(){c.push("/")})})}},mounted(){this.loadData(this.$route.query.id)}},o={};var h=n(v,m,p,!1,_,"bd37ccce",null,null);function _(t){for(let i in o)this[i]=o[i]}const f=function(){return h.exports}();export{f as default};