﻿using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        public static void AfficherMorpion(int j, int k)
        {
        	// A compléter
        
	        for (j = 0; j < grille.GetLength(0); j++)
	        {
	           Console.Write("\n|===|===|===|\n");
	           Console.Write("|");
	           for (k = 0; k < grille.GetLength(1); k++)
	           {
	           		if (grille[j,k]==1)
	           		{
	           			Console.Write(" O ");
	           		}
	           		
	           		if (grille[j,k]==2)
	           		{
	           			Console.Write(" X ");
	           		}
	           	
		           	if (grille[j,k] == 10)
		           	{
		           		Console.Write(" - ");
		           	}
		           
		       Console.Write("|");
	           }
	                
	        }
	    Console.Write("\n|===|===|===|\n");
        }

        // Fonction permettant de changer
        // dans le tableau quelgit  est le 
        // joueur qui à jouer
        // Bien vérifier que le joueur ne sort
        // pas du tableau et que la position
        // n'est pas déjà jouée
        public static bool AJouer(int j, int k, int joueur)
        {
        	
        	if (j <= 2 && j >= 0 && k <= 2 && k >= 0)
        	{
        		if (grille[j,k] == 10)
        		{
        			grille[j,k] = joueur;
        			        			
        			return true;
        		}
        		return false;
        	}
        	// A compléter
            return false;
        }

        // Fonction permettant de vérifier
        // si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {
        	if (grille[0.0]+grille[1.1]+grille[2.2])
        	{
        		return true;
        	}
        	
        	if (grille[2.0]+grille[1.1]+grille[0.2])
        	{
        		return true;
        	}
        	
        	if (grille[0.0]+grille[0.1]+grille[0.2])
        	{
        		return true;
        	}
        	
        	if (grille[1.0]+grille[1.1]+grille[1.2])
        	{
        		return true;
        	}
        	
        	if (grille[2.0]+grille[2.1]+grille[2.2])
        	{
        		return true;
        	}
        	
        	if (grille[0.0]+grille[1.0]+grille[2.0])
        	{
        		return true;
        	}
        	
        	if (grille[0.1]+grille[1.1]+grille[2.1])
        	{
        		return true;
        	}
        	
        	if (grille[0.2]+grille[1.2]+grille[2.2])
        	{
        		return true;
        	}
            // A compléter 
            return false;
        }

        // Programme principal3
        static void Main(string[] args)
        {
            //--- Déclarations et initialisations --
            int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre

            int essais = 0;    // compteur d'essais
	        int joueur = 1 ;   // 1 pour la premier joueur, 2 pour le second
	        int l, c = 0;      // numéro de ligne et de colonne
            int j, k = 0;      // Parcourir le tableau en 2 dimensions
            bool gagner = false; // Permet de vérifier si un joueur à gagné 
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible

	        //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
	        for (j=0; j < grille.GetLength(0); j++)
		        for (k=0; k < grille.GetLength(1); k++)
			        grille[j,k] = 10;
            while(!gagner && essais != 9)
            {

                // A compléter 
                AfficherMorpion(j,k);
                try
                {
                	Console.WriteLine("C'est au tour du joueur : " + joueur);
                    Console.WriteLine("Ligne   =    ");
                    Console.WriteLine("Colonne =    ");
                    // Peut changer en fonction de comment vous avez fait votre tableau.
                    Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9); // Permet de manipuler le curseur dans la fenêtre 
                    l = int.Parse(Console.ReadLine()) - 1; 
                    // Peut changer en fonction de comment vous avez fait votre tableau.
                    Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10); // Permet de manipuler le curseur dans la fenêtre 
                    c = int.Parse(Console.ReadLine()) - 1;
                    
                    bonnePosition = AJouer(l,c,joueur);
       
                    // A compléter
                    if (bonnePosition)
                    {
                    	if (joueur == 1)
                    	{
                    		joueur = 2;
	                    }
	                    else 
	                    {
                    		joueur = 1;
                   		}
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                // Changement de joueur
                // A compléter 
                Console.Clear();

            }; // Fin TQ

            // Fin de la partie
            // A compléter 

            Console.ReadKey(true);
        }
	}
}
