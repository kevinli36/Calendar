﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Calendar
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SigninPage : Page
    {
        public SigninPage()
        {
            this.InitializeComponent();
        }

        // 处理登录事件
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = InputUsername.Text;
            string password = InputPassword.Password;

            // check format
            if (!checkFormat(username, password)) {
                return;
            }
        }

        // 检查用户信息格式
        private bool checkFormat(string username, string password)
        {
            bool isPass = true;
            if (username == "")
            {
                UsernameError.Text = "请输入用户名";
                isPass = false;
            }
            if (password == "")
            {
                PasswordError.Text = "请输入密码";
                isPass = false;
            }

            return isPass;
        }

        // 跳转到注册页面
        private void SignupButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SignupPage), "");
        }
    }
}