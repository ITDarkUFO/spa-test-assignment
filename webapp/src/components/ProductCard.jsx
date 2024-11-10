import { Flex, Card, Typography } from 'antd';

import { useModal } from '../context/ModalContext';

import DeleteButton from './DeleteProductButton';

const { Text, Paragraph } = Typography;

const ProductCard = ({ product }) => {
    const { setViewEditModalProductId: setModalProductId, setIsViewEditModalVisible: setIsModalVisible } = useModal();

    const onClick = () => {
        console.log("Открытие модального окна просмотра товара");
        setModalProductId(product.Id);
        setIsModalVisible(true);
    };

    const CardTitle = () => {
        return (
            <Flex vertical gap={2} className="card-title">
                <Text ellipsis={true} className="card-title-name">{product.Name}</Text>
                <Text type="secondary">{product.Vendorcode}</Text>
            </Flex>
        );
    };

    const CardExtra = () => {
        return <DeleteButton productId={product.Id} />;
    };

    return (
        <Card hoverable title={<CardTitle />} extra={<CardExtra />} className="card" onClick={onClick}>
            <Flex vertical justify="space-between" className="card-body">
                <Paragraph ellipsis={{ rows: 5 }}>{product.Description}</Paragraph>

                <Flex align="flex-end" justify="space-between" className="card-text">
                    <Text className="card-text-quantity">Осталось {product.Quantity} шт.</Text>
                    <Text className="card-text-price">{product.Price}&#8381;</Text>
                </Flex>
            </Flex>
        </Card>
    );
};

export default ProductCard;