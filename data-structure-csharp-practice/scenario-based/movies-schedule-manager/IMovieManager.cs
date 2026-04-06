using System;
namespace movies_scheduler_manager
{
    interface IMovieManager
    {
        void AddMovie(string name,string date);
        void SearchMovie(string name);
        
    }
}