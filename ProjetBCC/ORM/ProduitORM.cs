﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ProjetBCC.Ctrl;
using ProjetBCC.DAO;

namespace ProjetBCC.ORM
{
    public class ProduitORM
    {
        public static ProduitViewModel getProduit(int id)
        {
            ProduitDAO pDAO = ProduitDAO.getProduit(id);
            ProduitViewModel p = new ProduitViewModel(pDAO.idDAO, pDAO.estimationActuelleDAO, pDAO.prixVenteDAO, pDAO.nomProduitDAO, pDAO.descriptionDAO, pDAO.artisteDAO, pDAO.styleDAO, pDAO.dateVenteDAO, pDAO.idLotDAO, pDAO.idPhotoDAO, pDAO.idAcheteurDAO, pDAO.idVendeurDAO);
            return p;
        }

        public static ObservableCollection<ProduitViewModel> listeProduits()
        {
            ObservableCollection<ProduitDAO> lDAO = ProduitDAO.listeProduits();
            ObservableCollection<ProduitViewModel> l = new ObservableCollection<ProduitViewModel>();
            foreach (ProduitDAO element in lDAO)
            {
                ProduitViewModel p = new ProduitViewModel(element.idDAO, element.estimationActuelleDAO, element.prixVenteDAO, element.nomProduitDAO, element.descriptionDAO, element.artisteDAO, element.styleDAO, element.dateVenteDAO, element.idLotDAO, element.idPhotoDAO, element.idAcheteurDAO, element.idVendeurDAO);
                l.Add(p);
            }
            return l;
        }
        public static void updateProduit(ProduitViewModel p)
        {
            ProduitDAO.updateProduit(new ProduitDAO(p.idProperty, p.estimationProperty, p.prixVenteProperty, p.nomProduitProperty, p.descriptionProperty, p.artisteProperty, p.styleProperty, p.dateVenteProperty, p.idLotProperty, p.idPhotoProperty, p.idAcheteurProperty, p.idVendeurProperty));
        }

        public static void supprimerProduit(int id)
        {
            ProduitDAO.supprimerProduit(id);
        }

        public static void insertProduit(ProduitViewModel p)
        {
            ProduitDAO.insertProduit(new ProduitDAO(p.idProperty, p.estimationProperty, p.prixVenteProperty, p.nomProduitProperty, p.descriptionProperty, p.artisteProperty, p.styleProperty, p.dateVenteProperty,  p.idLotProperty, p.idPhotoProperty, p.idAcheteurProperty, p.idVendeurProperty));
        }
    }
}