﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicPerfectizr.Domain;
using Moq;

namespace MusicPerfectizr.Tests
{
    [TestClass]
    public class FileOperatorTests
    {
        //[TestMethod]
        //public void Can_Get_New_Title()
        //{
        //    With_Valid_Tags();
        //    With_Invalid_Performer();
        //    With_Invalid_Title();
        //}

        //public void With_Valid_Tags()
        //{
        //    // Arrange
        //    // TODO: створювати власний об'єкт
        //    var file = TagLib.File.Create(Environment.CurrentDirectory +
        //        "//song.mp3");
        //    file.Tag.Performers = new[] { "Performer" };
        //    file.Tag.Title = "Title";
             
        //    var fileOperator = new FileOperator(null, 
        //        new UserOptions {TitleMode = Title.ArtistTitle}, null);
        //    int counter = 0;
        //    string result = "";

        //    // Act
        //    fileOperator.GetNewTitle(file, 
        //        ref result, ref counter);

        //    // Assert
        //    Assert.AreEqual("Performer - Title.mp3", result);
        //    Assert.AreEqual(1, counter);
        //}

        //public void With_Invalid_Performer()
        //{
        //    // Arrange
        //    // TODO: створювати власний об'єкт
        //    var file = TagLib.File.Create(Environment.CurrentDirectory +
        //        "//song.mp3");
        //    file.Tag.Performers = new[] { "" };
        //    file.Tag.Title = "Title";

        //    var fileOperator = new FileOperator(null,
        //        new UserOptions { TitleMode = Title.ArtistTitle }, null);
        //    int counter = 0;
        //    string result = "";

        //    // Act
        //    fileOperator.GetNewTitle(file,
        //        ref result, ref counter);

        //    // Assert
        //    Assert.AreEqual("Title.mp3", result);
        //    Assert.AreEqual(1, counter);
        //}

        //public void With_Invalid_Title()
        //{
        //    // Arrange
        //    // TODO: створювати власний об'єкт
        //    var file = TagLib.File.Create(Environment.CurrentDirectory +
        //        "//song.mp3");
        //    file.Tag.Performers = new[] { "Performer" };
        //    file.Tag.Title = "";

        //    var fileOperator = new FileOperator(null,
        //        new UserOptions { TitleMode = Title.ArtistTitle }, null);
        //    int counter = 0;
        //    string result = "song";

        //    // Act
        //    fileOperator.GetNewTitle(file,
        //        ref result, ref counter);

        //    // Assert
        //    Assert.AreEqual("Performer - song.mp3", result);
        //    Assert.AreEqual(1, counter);
        //}

    }
}
