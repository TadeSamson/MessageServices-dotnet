# MessageServices  for dotnet
.Net Wrapper for Different Email and Sms services including Mandrilll . 

# Description
MessageServices for dotnet library is an all in one messaging service pack. It implements several email and sms messaging services such as mandrill by programming all to one common interface. Each messaging services are structures to mimick the targeted service provider. By implementing a factory method pattern, it enables one point of initialization for all message service type.
   
#Usage

            MessageServicesManager manager = new MessageServicesManager();
            MandrillMessageService mandril = (MandrillMessageService)manager.CreateMessageService(MessageServiceType.Mandrill, "key");
            MandrillMessageInformation messageInfo = new MandrillMessageInformation();
            messageInfo.message.from_email = "email@emailfrom.com";
            messageInfo.message.from_name = "from_name";
            messageInfo.message.subject = "subject";
            messageInfo.message.to.Add(new ToEmail() { email = "email@toemail.com", name ="to_name" , type = "to" });
            messageInfo.template_name = "template_name";
            List<Response> responses = mandril.Message.Send(messageInfo);
            
#Prerequisite
.Net framework 4.5 and later as it uses async and await
