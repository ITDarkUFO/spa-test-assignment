import { Button } from 'antd';
import { PlusOutlined } from '@ant-design/icons';
import { useModal } from '../context/ModalContext';


const CreateProductButton = () => {
    const { setIsCreateModalVisible: setIsModalVisible } = useModal();

    const handleClick = () => {
        console.log("Открытие модального окна добавления товара");
        setIsModalVisible(true);
    };

    return (
        <Button type="primary" size="large" icon={<PlusOutlined />} onClick={handleClick}>Добавить товар</Button>
    );
};

export default CreateProductButton;