/* Le han pedido que agregue una característica al software de su empresa. 
La característica está pensada para mejorar la tasa de renovación de las suscripciones al software. 
Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de 
software y se notifica que su suscripción finaliza pronto. Para cumplir los requisitos, necesitará agregar 
un par de instrucciones de decisión para agregar lógica de rama a la aplicación.

Regla 1. Si la suscripción del usuario expira en 10 días o menos, muestre el mensaje:
Your subscription will expire soon. Renew now!

Regla 2. Si la suscripción del usuario expira en cinco días o menos, muestre los mensajes:
Your subscription expires in x days.
Renew now and save 10%!

Regla 3. Si la suscripción del usuario expira en un día, muestre el mensaje:
Your subscription expires within a day!
Renew now and save 20%!

Regla 4. Si la suscripción del usuario ha expirado, muestre el mensaje:
Your subscription has expired.

Regla 5. Si la suscripción del usuario expira en más de 10 días, no mostrar nada.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
        discountPercentage += 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
        discountPercentage += 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}