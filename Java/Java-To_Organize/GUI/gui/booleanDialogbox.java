package gui;

import javax.swing.JOptionPane;

public class booleanDialogbox{
    public static void main(String[] args){
        boolean contactServerUp;

//
        int contactServerEntry = JOptionPane.showConfirmDialog(null,
                                 "Is the contact server up", "Please select",
                                 JOptionPane.YES_NO_OPTION);
        System.out.println("result from entry " + contactServerEntry);
    
        if(contactServerEntry==1) 
           contactServerUp = true;
        else
          if(contactServerEntry==0)
             contactServerUp = false; 
        /* System.out.println(contactServerUp); */
       }}