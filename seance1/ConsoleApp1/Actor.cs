﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;



namespace ConsoleApp1
{
    [Serializable]
    internal class Actor : Person {


    private readonly int _sizeInCentimeter;
    private List<Movie> _movies;

public int SizeInCentimeter()
{
    return _sizeInCentimeter;
}



public Actor(string name, string firstname, DateTime birthDate, int sizeInCentimeter) : base(name, firstname, birthDate)
{
    this._sizeInCentimeter = sizeInCentimeter;
    this._movies = new List<Movie>();
}



    public string ToString()
{
    return "Actor [name = " + Name + " firstname = " + Firstname + " sizeInCentimeter = " + SizeInCentimeter() + " birthdate = " + BirthDate + "]";
}

/**
 * 
 * @return list of movies in which the actor has played
 */
public IEnumerator<Movie> Movies()
{
    return _movies.GetEnumerator();
}

/**
 * add movie to the list of movies in which the actor has played
 * @param movie
 * @return false if the movie is null or already present
 */
public bool AddMovie(Movie movie)
{
    if ((movie == null) || movies.contains(movie))
        return false;

    if (!movie.containsActor(this))
        movie.addActor(this);

    _movies.add(movie);

    return true;
}

public bool ContainsMovie(Movie movie)
{
    return _movies.contains(movie);
}

    public override string Name
{
      get { return base.Name.toUpper(); }
}
}
}
