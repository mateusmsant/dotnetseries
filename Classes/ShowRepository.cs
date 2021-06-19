using System;
using System.Collections.Generic;
using series.Interfaces;
namespace series
{
  public class ShowRepository : IRepository<Show>
  {
    private List<Show> showList = new List<Show>();

    public void Delete(int id)
    {
      showList[id].Delete();
    }

    public List<Show> List()
    {
      return showList;
    }

    public int NextId()
    {
      return showList.Count;
    }

    public void Put(Show entity)
    {
      showList.Add(entity);
    }

    public Show ReturnById(int id)
    {
      return showList[id];
    }

    public void Update(int id, Show entity)
    {
      showList[id] = entity;
    }
  }
}