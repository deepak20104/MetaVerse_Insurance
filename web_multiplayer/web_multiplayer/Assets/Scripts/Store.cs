using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Store : MonoBehaviour
{
public TMP_InputField Username;
public TMP_InputField Email;
public TMP_InputField Phone_no;
public TMP_InputField Password;
public TMP_InputField Re_TypePassword;
private string connectionString;
private MySqlConnection MS_Connection;
private MySqlCommand MS_Command;
string query;



public void sendInfo()
{
    connection();
    query="insert into registration(Username,Email,Phone_No,Password,Re_TypePass) values('"+Username.text+"','"+Email.text+"','"+Phone_no.text+"','"+Password.text+"','"+Re_TypePassword.text+"');";

    MS_Command= new MySqlCommand(query,MS_Connection);

    MS_Command.ExecuteNonQuery();

    MS_Connection.Close();
    SceneManager.LoadScene(sceneName:"login_screen");

}


public void connection(){

    connectionString = "Server = 127.0.0.1; Database=test;User = root; Password = ;Charset = utf8;";
    MS_Connection = new MySqlConnection(connectionString);

    MS_Connection.Open();
}

}
